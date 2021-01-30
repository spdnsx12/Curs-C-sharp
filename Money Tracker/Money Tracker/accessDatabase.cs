using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Tracker
{
    public class accessDatabase
    {

        public static List<Venituri> incarcaVenituri()
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venit = cnn.Query<Venituri>("Select * from venituri", new DynamicParameters());
                return venit.ToList();
            }
        }

        public static void salveazaVenituri(Venituri venit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                cnn.Execute("Insert into venituri(descriere, suma, tipVenit, dataVenit) values(@descriere, @suma, @tipVenit, @dataVenit)", venit);
            }
        }

        public static void DeleteVenituri(Venituri venit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                cnn.Execute("Delete from venituri where id = @id and descriere = @descriere and suma = @suma and tipVenit = @tipVenit and dataVenit = @dataVenit", venit);
            }
        }

        public static void UpdateVenituri(Venituri venit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                cnn.Execute("Update venituri set descriere = @descriere and suma = @suma and tipVenit = @tipVenit and dataVenit = @dataVenit where id = @id", venit);
            }
        }

        public static List<Cheltuieli> incarcaCheltuieli()
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli", new DynamicParameters());
                return cheltuieli.ToList();
            }
        }


        public static void salveazaCheltuieli(Cheltuieli cheltuiala)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                cnn.Execute("Insert into cheltuieli(descriere, suma, tipPlata, dataTranzactie) values(@descriere, @suma, @tipPlata, @dataTranzactie)", cheltuiala);
            }
        }


        public static void DeleteCheltuieli(Cheltuieli cheltuiala)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                cnn.Execute("Delete from cheltuieli where id = @id and descriere = @descriere and suma = @suma and tipPlata = @TipPlata and dataTranzactie = @DataTranzactie", cheltuiala);
            }
        }

        public static void UpdateCheltuieli(Cheltuieli cheltuiala)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                cnn.Execute("Update cheltuieli set descriere = @descriere and suma = @suma and tipPlata = @TipPlata and dataTranzactie = @DataTranzactie where id = @id", cheltuiala);
            }
        }

        public static List<Economii> incarcaEconomii()
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var economii = cnn.Query<Economii>("Select * from economii", new DynamicParameters());
                return economii.ToList();
            }
        }

        public static void salveazaEconomii(Economii economie)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                cnn.Execute("Insert into economii(descriere,suma,dataAdaugare) values(@descriere, @suma, @dataAdaugare)", economie);
            }

        }

        public static void DeleteEconomii(Economii economie)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                cnn.Execute("Delete from economii where id = @id and descriere = @descriere and suma = @suma and dataAdaugare = @dataAdaugare", economie);
            }
        }

        public static void UpdateEconomii(Economii economie)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                cnn.Execute("Update economii set descriere = @descriere and suma = @suma and dataAdaugare = @dataAdaugare where id = @id", economie);
            }
        }

        //filtru pe descriere
        public static List<Venituri> FiltruDescriereVenit(string descriere)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where descriere like '%" + descriere.ToString() + "%'", new DynamicParameters());
                return venituri.ToList();
            }
        }

        // filtru pe venit
        public static List<Venituri> FiltruSumaVenit(decimal suma)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where suma = " + suma, new DynamicParameters());
                return venituri.ToList();
            }
        }

        //filtru pe Data
        public static List<Venituri> FiltruDataVenit(string data)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where dataVenit = '" + data + "'", new DynamicParameters());
                return venituri.ToList();
            }
        }

        //filtru pe tipVenit
        public static List<Venituri> FiltruTipVenit(string tipPlata)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where tipVenit = '" + tipPlata + "'", new DynamicParameters());
                return venituri.ToList();
            }
        }

        //filtru pe descriere si suma
        public static List<Venituri> FiltruDescriereSumaVenit(string descriere, decimal suma)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where descriere like '%" + descriere.ToString() + "%' and suma = " + suma, new DynamicParameters());
                return venituri.ToList();
            }
        }
        
        //filtru pe descriere,suma,tip
        public static List<Venituri> FiltruDescriereSumaTipVenit(string descriere, decimal suma,string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where descriere like '%" + descriere +
                                                                                "%' and suma = " + suma +
                                                                                "  and tipVenit = '" + tipVenit + "'", new DynamicParameters());
                return venituri.ToList();
            }
        }

        //filtru pe descriere,suma,data,tip
        public static List<Venituri> FiltruDescriereSumaDataTipVenit(string descriere, decimal suma, string data,string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where descriere like '%" + descriere +
                                                                                "%' and suma = " + suma +
                                                                                "  and dataVenit = '" + data +
                                                                                "'  and tipVenit = '" + tipVenit + "'", new DynamicParameters());
                return venituri.ToList();
            }
        }
        //filtru pe descriere,data,tip
        public static List<Venituri> FiltruDescriereDataTipVenit(string descriere, string data, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where descriere like '%" + descriere +
                                                                                "%' and dataVenit = '" + data +
                                                                                "'  and tipVenit = '" + tipVenit + "'", new DynamicParameters());
                return venituri.ToList();
            }
        }
        //filtru pe descriere,data,
        public static List<Venituri> FiltruDescriereDataVenit(string descriere, string data)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where descriere like '%" + descriere +
                                                                                "%' and dataVenit = '" + data +"'",new DynamicParameters());
                return venituri.ToList();
            }
        }
        //filtru pe descriere,tip
        public static List<Venituri> FiltruDescriereTipVenit(string descriere, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where descriere like '%" + descriere +
                                                                                "%'  and tipVenit = '" + tipVenit + "'", new DynamicParameters());
                return venituri.ToList();
            }
        }

        //filtru pe suma,tip
        public static List<Venituri> FiltruSumaTipVenit(decimal suma, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where suma = " + suma +
                                                                          "  and tipVenit = '" + tipVenit + "'", new DynamicParameters());
                return venituri.ToList();

            }
        }
        //filtru pe suma,data
        public static List<Venituri> FiltruSumaDataVenit(decimal suma, string data)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where suma = " + suma +
                                                                          "  and dataVenit = '" + data + "'", new DynamicParameters());

                return venituri.ToList();
            }
        }
        //filtru pe suma,data,tip
        public static List<Venituri> FiltruSumaDataTipVenit(decimal suma, string data, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where suma = " + suma +
                                                                          "  and dataVenit = '" + data +
                                                                         "'  and tipVenit = '" + tipVenit + "'", new DynamicParameters());
                return venituri.ToList();
            }
        }
        //filtru pe suma,data,tip
        public static List<Venituri> FiltruDataTipVenit(string data, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var venituri = cnn.Query<Venituri>("Select * from venituri where dataVenit = '" + data +
                                                                         "'  and tipVenit = '" + tipVenit + "'", new DynamicParameters());
                return venituri.ToList();
            }
        }

        //FILTRE CHELTUIELI

        //filtru pe descriere
        public static List<Cheltuieli> FiltruDescriereCheltuiala(string descriere)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where descriere like '%" + descriere.ToString() + "%'", new DynamicParameters());
                return cheltuieli.ToList();
            }
        }

        // filtru pe venit
        public static List<Cheltuieli> FiltruSumaCheltuiala(decimal suma)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where suma = " + suma, new DynamicParameters());
                return cheltuieli.ToList();
            }
        }

        //filtru pe Data
        public static List<Cheltuieli> FiltruDataCheltuiala(string data)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where dataTranzactie = '" + data + "'", new DynamicParameters());
                return cheltuieli.ToList();
            }
        }

        //filtru pe tipVenit
        public static List<Cheltuieli> FiltruTipCheltuiala(string tipPlata)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where tipPlata = '" + tipPlata + "'", new DynamicParameters());
                return cheltuieli.ToList();
            }
        }

        //filtru pe descriere si suma
        public static List<Cheltuieli> FiltruDescriereSumaCheltuiala(string descriere, decimal suma)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where descriere like '%" + descriere.ToString() + "%' and suma = " + suma, new DynamicParameters());
                return cheltuieli.ToList();
            }
        }

        //filtru pe descriere,suma,tip
        public static List<Cheltuieli> FiltruDescriereSumaTipCheltuiala(string descriere, decimal suma, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where descriere like '%" + descriere +
                                                                                "%' and suma = " + suma +
                                                                                "  and tipPlata = '" + tipVenit + "'", new DynamicParameters());
                return cheltuieli.ToList();
            }
        }

        //filtru pe descriere,suma,data,tip
        public static List<Cheltuieli> FiltruDescriereSumaDataTipCheltuiala(string descriere, decimal suma, string data, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where descriere like '%" + descriere +
                                                                                "%' and suma = " + suma +
                                                                                "  and dataTranzactie = '" + data +
                                                                                "'  and tipPlata = '" + tipVenit + "'", new DynamicParameters());
                return cheltuieli.ToList();
            }
        }
        //filtru pe descriere,data,tip
        public static List<Cheltuieli> FiltruDescriereDataTipCheltuiala(string descriere, string data, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where descriere like '%" + descriere +
                                                                                "%' and dataTranzactie = '" + data +
                                                                                "'  and tipPlata = '" + tipVenit + "'", new DynamicParameters());
                return cheltuieli.ToList();
            }
        }
        //filtru pe descriere,data,
        public static List<Cheltuieli> FiltruDescriereDataCheltuiala(string descriere, string data)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where descriere like '%" + descriere +
                                                                                "%' and dataTranzactie = '" + data + "'", new DynamicParameters());
                return cheltuieli.ToList();
            }
        }
        //filtru pe descriere,tip
        public static List<Cheltuieli> FiltruDescriereTipCheltuiala(string descriere, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where descriere like '%" + descriere +
                                                                                "%'  and tipPlata = '" + tipVenit + "'", new DynamicParameters());
                return cheltuieli.ToList();
            }
        }

        //filtru pe suma,tip
        public static List<Cheltuieli> FiltruSumaTipCheltuiala(decimal suma, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where suma = " + suma +
                                                                          "  and tipPlata = '" + tipVenit + "'", new DynamicParameters());
                return cheltuieli.ToList();

            }
        }
        //filtru pe suma,data
        public static List<Cheltuieli> FiltruSumaDataCheltuiala(decimal suma, string data)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where suma = " + suma +
                                                                          "  and dataTranzactie = '" + data + "'", new DynamicParameters());

                return cheltuieli.ToList();
            }
        }
        //filtru pe suma,data,tip
        public static List<Cheltuieli> FiltruSumaDataTipCheltuiala(decimal suma, string data, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where suma = " + suma +
                                                                          "  and dataTranzactie = '" + data +
                                                                         "'  and tipPlata = '" + tipVenit + "'", new DynamicParameters());
                return cheltuieli.ToList();
            }
        }
        //filtru pe suma,data,tip
        public static List<Cheltuieli> FiltruDataTipCheltuiala(string data, string tipVenit)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var cheltuieli = cnn.Query<Cheltuieli>("Select * from cheltuieli where dataTranzactie = '" + data +
                                                                         "'  and tipPlata = '" + tipVenit + "'", new DynamicParameters());
                return cheltuieli.ToList();
            }
        }

        //FILTRE ECONOMII

        //filtru pe descriere
        public static List<Economii> FiltruDescriereEconomie(string descriere)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var economii = cnn.Query<Economii>("Select * from economii where descriere like '%" + descriere.ToString() + "%'", new DynamicParameters());
                return economii.ToList();
            }
        }

        // filtru pe suma
        public static List<Economii> FiltruSumaEconomie(decimal suma)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var economii = cnn.Query<Economii>("Select * from economii where suma = " + suma, new DynamicParameters());
                return economii.ToList();
            }
        }

        //filtru pe Data
        public static List<Economii> FiltruDataEconomie(string data)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var economii = cnn.Query<Economii>("Select * from economii where dataAdaugare = '" + data + "'", new DynamicParameters());
                return economii.ToList();
            }
        }

        //filtru pe descriere si suma
        public static List<Economii> FiltruDescriereSumaEconomie(string descriere, decimal suma)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var economii = cnn.Query<Economii>("Select * from economii where descriere like '%" + descriere.ToString() + "%' and suma = " + suma, new DynamicParameters());
                return economii.ToList();
            }
        }

        //filtru pe descriere,suma,data,tip
        public static List<Economii> FiltruDescriereSumaDataEconomie(string descriere, decimal suma, string data)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var economii = cnn.Query<Economii>("Select * from economii where descriere like '%" + descriere +
                                                                                "%' and suma = " + suma +
                                                                                "  and dataAdaugare = '" + data + "'" , new DynamicParameters());
                return economii.ToList();
            }
        }

        //filtru pe descriere,data,
        public static List<Economii> FiltruDescriereDataEconomie(string descriere, string data)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var economii = cnn.Query<Economii>("Select * from economii where descriere like '%" + descriere +
                                                                                "%' and dataAdaugare = '" + data + "'", new DynamicParameters());
                return economii.ToList();
            }
        }

        //filtru pe suma,data
        public static List<Economii> FiltruSumaDataEconomie(decimal suma, string data)
        {
            using (IDbConnection cnn = new SQLiteConnection(IncarcaInfo()))
            {
                var economii = cnn.Query<Economii>("Select * from economii where suma = " + suma +
                                                                          "  and dataAdaugare = '" + data + "'", new DynamicParameters());

                return economii.ToList();
            }
        }



        public static string IncarcaInfo(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }




    }
}

