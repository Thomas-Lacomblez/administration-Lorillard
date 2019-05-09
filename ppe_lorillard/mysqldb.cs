using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace ppe_lorillard
{
    class MySqlDB
    {
        //variables
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private List<observateur> tabO;
        private List<site> tab1;
        private List<observation> tab2;
        private List<zone> tab3;
        private List<equipe> tab4;
        private int valueIdBddObservateur;
        private int ObservationStatsSite;
        private List<string> SiteStats = new List<string>();
        private int TempsObsTotal;
        private int ObservationTemps;
        private int PersonnesObserveTotal;
        private List<int> ObservationPersonne = new List<int>();
        private int PersonneContacte;
        private DataTable _dt1;
        private DataTable _dt2;
        private DataTable _dt3;

        //Constructeur
        public MySqlDB(string monServeur, string maDatabase, string monCompte, string monMotDePasse)
        {
            server = monServeur;
            database = maDatabase;
            uid = monCompte;
            password = monMotDePasse;
            tabO = new List<observateur>();
            tab1 = new List<site>();
            tab2 = new List<observation>();
            tab3 = new List<zone>();
            tab4 = new List<equipe>();


            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection(MySqlConnection connexion)
        {
            try
            {
                connexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        Console.WriteLine("Cannot connect to server. Contact administrator");
                        //throw new Exception("Cannot connect to server. Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        Console.WriteLine("Invalid username/password, please try again");
                        //throw new Exception("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection(MySqlConnection connexion)
        {
            try
            {
                connexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Insert statement
        public string Exec(string query)
        {
            string value = "";
            //open connection
            if (this.OpenConnection(connection) == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                int count = cmd.ExecuteNonQuery();

                if (count != 0)
                {
                    value = "succes";
                }
                else
                {
                    value = "error";
                }
                //close connection
                this.CloseConnection(connection);

            }
            return value;
        }

        public List<observateur> GetObservateur()
        {

            using (var connection2 = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";"))
            {
                if (OpenConnection(connection2))
                {



                    //Create Command
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM observateur", connection2);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        observateur myStatement = new observateur(int.Parse(dataReader["id"].ToString()), dataReader["nom"].ToString(), dataReader["prenom"].ToString(), dataReader["mail"].ToString(), dataReader["login"].ToString(), dataReader["mdp"].ToString());
                        tabO.Add(myStatement);
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection2.Close();
                }
            }
            return tabO;
        }

        public int GetBddidObservateur(string res)
        {
            //Open connection
            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT observateur.id FROM observateur WHERE observateur.nom = " + "\"" + res + "\"", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    valueIdBddObservateur = int.Parse(dataReader["id"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);

            }
            return valueIdBddObservateur;
        }
        // fonction qui retourne les observation classer par site pour les Statistiques.
        public int GetObservationStatsSite()
        {
            //Open connection
            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT Count(observation.id) as NombreObservation,idSite FROM `observation` GROUP BY idSite", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ObservationStatsSite = int.Parse(dataReader["NombreObservation"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);

            }
            return ObservationStatsSite;
        }
        public string[] GetSiteStats()
        {
            //Open connection
            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(observation.id) as NbObservation, site.id, site.nom FROM observation, site WHERE observation.idSite = site.id GROUP BY site.id", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    SiteStats.Add(dataReader["nom"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);

            }
            return SiteStats.ToArray();
        }

        public int GetTempsObsTotal()
        {
            //Open connection
            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT SUM(tempsObs) as tempsTotal FROM observation", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    TempsObsTotal = int.Parse(dataReader["tempsTotal"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);

            }
            return TempsObsTotal;
        }

        public int GetObservationStatsTemps()
        {
            //Open connection
            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT SUM(tempsObs) as tempsTotal, COUNT(observation.id) as NombreTotalObservation FROM `observation`", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ObservationTemps = int.Parse(dataReader["NombreTotalObservation"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);

            }
            return ObservationTemps;
        }
        public int GetObservationStatsPersonne()
        {
            //Open connection
            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT SUM(`nbPersObs`) as PersonneObserveTotal FROM `observation`", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    PersonnesObserveTotal = int.Parse(dataReader["PersonneObserveTotal"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);

            }
            return PersonnesObserveTotal;
        }
        public int[] GetNbObservationParSite()
        {
            //Open connection
            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(observation.id) as NbObservation, site.id, site.nom FROM observation, site WHERE observation.idSite = site.id GROUP BY site.id", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ObservationPersonne.Add(int.Parse(dataReader["NbObservation"].ToString()));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);

            }

            return ObservationPersonne.ToArray();
        }

        public int GetPersonneContacteStats()
        {
            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT SUM(`nbPersContact`) as PersonneObserveTotal FROM `observation`", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    PersonneContacte = int.Parse(dataReader["PersonneObserveTotal"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);

            }
            return PersonneContacte;
    }

        public DataTable GetDataTableObservateur()
        {
            //Open connection
            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM observateur", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                _dt1 = new DataTable();
                _dt1.Columns.Add("id",
                  System.Type.GetType("System.Int32") ?? throw new ArgumentNullException());
                _dt1.Columns.Add("Nom",
                    System.Type.GetType("System.String") ?? throw new ArgumentNullException());
                _dt1.Columns.Add("Prénom",
                    System.Type.GetType("System.String") ?? throw new ArgumentNullException());
                _dt1.Columns.Add("mail",
                    System.Type.GetType("System.String") ?? throw new ArgumentNullException());
                _dt1.Columns.Add("login",
                   System.Type.GetType("System.String") ?? throw new ArgumentNullException());
                _dt1.Columns.Add("mdp",
                   System.Type.GetType("System.String") ?? throw new ArgumentNullException());

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    _dt1.Rows.Add(new object[]
                        { int.Parse(dataReader["id"].ToString()), dataReader["nom"].ToString(), dataReader["prenom"].ToString(), dataReader["mail"].ToString(), dataReader["login"].ToString(), dataReader["mdp"].ToString() });
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);

            }
            return _dt1;
        }

        public List<site> GetSites()
        {
            //Open connection
            using (var connection5 = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" +
                 database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";"))
            {
                if (this.OpenConnection(connection5) == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM site", connection5);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        site UnSite = new site(int.Parse(dataReader["id"].ToString()), dataReader["nom"].ToString(), dataReader["adresse"].ToString());
                        tab1.Add(UnSite);
                    }

                    //close Data Reader
                    dataReader.Close();
                }
                //close Connection
                connection5.Close();

            }
            return tab1;
        }

        public DataTable GetDataTableSites()
        {
            //Open connection
            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM site", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                _dt2 = new DataTable();
                _dt2.Columns.Add("id",
                  System.Type.GetType("System.Int32") ?? throw new ArgumentNullException());
                _dt2.Columns.Add("Nom",
                    System.Type.GetType("System.String") ?? throw new ArgumentNullException());
                _dt2.Columns.Add("adresse",
                    System.Type.GetType("System.String") ?? throw new ArgumentNullException());

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    _dt2.Rows.Add(Int32.Parse(dataReader["id"].ToString()), dataReader["nom"].ToString(), dataReader["adresse"].ToString());
                    /*  site UnSite = new site(int.Parse(dataReader["id"].ToString()), dataReader["nom"].ToString(), dataReader["adresse"].ToString());
                      tab1.Add(UnSite);*/
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);

            }
            else
            {

            }
            return _dt2;
        }

        public string GetString(string nom)
        {
            string value = "0";

            if (string.IsNullOrEmpty(nom))
            {
                return value;
            }
            else
            {
                return nom;
            }
        }

        public DataTable GetDataTableObservations()
        {
            //Open connection

            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM observation", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                _dt3 = new DataTable();

                _dt3.Columns.Add("id de l'observation",
                    System.Type.GetType("System.Int32"));
                _dt3.Columns.Add("observateur",
                    System.Type.GetType("System.String"));
                _dt3.Columns.Add("date de l'observation",
                    System.Type.GetType("System.DateTime"));
                _dt3.Columns.Add("temps Observer",
                    System.Type.GetType("System.Int32"));
                _dt3.Columns.Add("Nombre de Personnes contacter",
                    System.Type.GetType("System.Int32"));
                _dt3.Columns.Add("Nombre de Personnes Observer",
                    System.Type.GetType("System.Int32"));
                _dt3.Columns.Add("Equipes",
                   System.Type.GetType("System.String"));
                _dt3.Columns.Add("Zones",
                  System.Type.GetType("System.String"));
                _dt3.Columns.Add("Sites",
                  System.Type.GetType("System.String"));

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    _dt3.Rows.Add(new object[]
                     {Int32.Parse(dataReader["id"].ToString()),this.GetObservateur()[Int32.Parse(dataReader["idObservateur"].ToString())- 1].GetNom() +" - "+this.GetObservateur()[Int32.Parse(dataReader["idObservateur"].ToString())- 1].GetPrenom(), DateTime.Parse(dataReader["date"].ToString()), Int32.Parse(dataReader["tempsObs"].ToString()), Int32.Parse(dataReader["nbPersContact"].ToString()), Int32.Parse(dataReader["nbPersObs"].ToString()), this.GetEquipes()[Int32.Parse(dataReader["idEquipe"].ToString()) - 1].GetIdEquipe() +" - "+ this.GetEquipes()[Int32.Parse(dataReader["idEquipe"].ToString()) - 1].GetNomEquipe(), this.GetZone()[Int32.Parse(dataReader["idZone"].ToString()) - 1].GetIdZone() +" - "+ this.GetZone()[Int32.Parse(dataReader["idZone"].ToString()) - 1].GetNomZone(), this.GetSites()[Int32.Parse(dataReader["idSite"].ToString()) - 1].GetId() +" - "+ this.GetSites()[Int32.Parse(dataReader["idSite"].ToString()) - 1].GetNom()});
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);
            }
            return _dt3;
        }
        public List<observation> GetObservations()
        {
            //Open connection
            if (this.OpenConnection(connection) == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM observation", connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    observation UneObservation = new observation(Int32.Parse(GetString(dataReader["id"].ToString())), Int32.Parse(GetString(dataReader["idObservateur"].ToString())), DateTime.Parse(dataReader["date"].ToString()), Int32.Parse(GetString(dataReader["tempsObs"].ToString())), Int32.Parse(GetString(dataReader["nbPersContact"].ToString())), Int32.Parse(GetString(dataReader["nbPersObs"].ToString())), Int32.Parse(GetString(dataReader["idSite"].ToString())), Int32.Parse(GetString(dataReader["idZone"].ToString())), Int32.Parse(GetString(dataReader["idEquipe"].ToString())));
                    tab2.Add(UneObservation);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection(connection);

            }
            return tab2;
        }
        public List<zone> GetZone()
        {
            //Open connection
            using (var connection4 = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" +
                 database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";"))
            {
                if (this.OpenConnection(connection4) == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM zone", connection4);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        zone Unezone = new zone(int.Parse(dataReader["id"].ToString()), dataReader["nom"].ToString(), int.Parse(dataReader["idSite"].ToString()));
                        tab3.Add(Unezone);
                    }

                    //close Data Reader
                    dataReader.Close();
                }
                //close Connection
                connection4.Close();

            }
            return tab3;
        }
        public List<equipe> GetEquipes()
        {
            using (var connection3 = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" +
                 database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";"))
            {
                if (this.OpenConnection(connection3) == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM equipe", connection3);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        equipe UneEquipe = new equipe(int.Parse(dataReader["id"].ToString()), dataReader["nom"].ToString(), int.Parse(dataReader["idZone"].ToString()));
                        tab4.Add(UneEquipe);
                    }

                    //close Data Reader
                    dataReader.Close();
                }
                //close Connection
                connection3.Close();

            }
            return tab4;
        }

        
    }
}
