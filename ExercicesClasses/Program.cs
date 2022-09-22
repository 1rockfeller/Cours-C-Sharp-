using System;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;

namespace ExercicesClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateTable();
            DisplayData();
            Console.ReadKey();
        }

        public static void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creation de la connexion  
                con = new SqlConnection("data source=51.79.69.136,1433; database=BaseRock; User ID = sa; Password = P@$$w0rd");
                // la requete sql  
                SqlCommand cm = new SqlCommand("create table student(id int not null, name varchar(100), email varchar(50), join_date date)", con);
                // Ouvrir la connexion  
                con.Open();
                // Executer la requete  
                cm.ExecuteNonQuery(); 
                Console.WriteLine("Table cree");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs,Erreur" + e);
            }
            // Fermer la connexion  
            finally
            {
                con.Close();
            }
        }



        public static void DisplayData()
        {
            SqlConnection con = null;
            try
            {
                // Creation de la connexion 
                con = new SqlConnection("data source=51.79.69.136,1433; database=BaseRock; User ID = sa; Password = P@$$w0rd");

                // la requete sql  
                SqlCommand cm = new SqlCommand("Select * from student", con);
                //  Ouvrir la connexion  
                con.Open();
                //  Executer la requete   
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    // Afficher  
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]);
                }

                Console.WriteLine("Succes");

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, Erreur." + e);
            }
            //Fermer la connexion  
            finally
            {
                con.Close();
            }
        }
    }
}
