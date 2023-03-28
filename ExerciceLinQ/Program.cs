using LinQ_DataContext;

DataContext dc = new DataContext();

/*2.1*/
/*Ecrire une requête pour présenter, pour chaque étudiant, le nom de l’étudiant, la
date de naissance, le login et le résultat pour l’année de l’ensemble des étudiants.*/

/*var result_2_1 = dc.Students.Select(s => new { 
                                        Nom = s.Last_Name,
                                        DateNaissance = s.BirthDate,
                                        s.Login,
                                        Resultat = s.Year_Result });

var result_2_1 = from Student s in dc.Students
                 select new
                 {
                     Nom = s.Last_Name,
                     DateNaissance = s.BirthDate,
                     s.Login,
                     Resultat = s.Year_Result
                 };

foreach (var item in result_2_1)
{
    Console.WriteLine($"{item.Nom} {item.DateNaissance} {item.Login} {item.Resultat}");
}
*/
/*2.2*/
/*Ecrire une requête pour présenter, pour chaque étudiant, son nom complet (nom
et prénom séparés par un espace), son id et sa date de naissance.*/

/*var result_2_2 = from Student s in dc.Students
                 select new
                 {
                     NomComplet = s.Last_Name + " " + s.First_Name,
                     Id = s.Student_ID,
                     DateNaissance = s.BirthDate
                 };

var result_2_2 = dc.Students.Select(s => new {
                                            NomComplet = s.Last_Name + " " + s.First_Name,
                                            Id = s.Student_ID,
                                            DateNaissance = s.BirthDate
                                        });

foreach (var item in result_2_2)
{
    Console.WriteLine($"{item.NomComplet} {item.DateNaissance} {item.Id}");
}*/

/*2.3*/
/*Ecrire une requête pour présenter, pour chaque étudiant, dans une seule chaine de
caractère l’ensemble des données relatives à un étudiant séparées par le symbole |.*/

/*IEnumerable<string> result_2_3 = dc.Students.Select(s => string.Join(" | ", s.Student_ID, s.Last_Name, s.First_Name, s.BirthDate, s.Login, s.Year_Result, s.Section_ID, s.Course_ID));

IEnumerable<string> result_2_3 = from Student s in dc.Students
                                 select string.Join(" | ", s.Student_ID, s.Last_Name, s.First_Name, s.BirthDate, s.Login, s.Year_Result, s.Section_ID, s.Course_ID);

foreach (string item in result_2_3)
{
    Console.WriteLine(item);
}*/

/*3.1*/
/*Pour chaque étudiant né avant 1955, donner le nom, le résultat annuel et le statut.
Le statut prend la valeur « OK » si l’étudiant à obtenu au moins 12 comme résultat annuel
et « KO » dans le cas contraire.*/

/*var result_3_1 = dc.Students.Where(s => s.BirthDate.Year < 1955)
                            .Select(s => new
                            {
                                Nom = s.Last_Name,
                                Resultat = s.Year_Result,
                                Status = (s.Year_Result >= 12) ? "Ok" : "KO"
                            });
var result_3_1 = from Student s in dc.Students
                 where s.BirthDate.Year < 1955
                 select new {
                     Nom = s.Last_Name,
                     Resultat = s.Year_Result,
                     Status = (s.Year_Result >= 12) ? "Ok" : "KO"
                 };

foreach (var item in result_3_1)
{
    Console.WriteLine($"{item.Nom} {item.Resultat} : {item.Status}");
}*/

/*3.2*/
/*Donner pour chaque étudiant entre 1955 et 1965 le nom, le résultat annuel et la
catégorie à laquelle il appartient. La catégorie est fonction du résultat annuel obtenu ; un
résultat inférieur à 10 appartient à la catégorie « inférieure », un résultat égal à 10 appartient
à la catégorie « neutre », un résultat autre appartient à la catégorie « supérieure ».*/

/*var result_3_2 = dc.Students.Where(s => s.BirthDate.Year >= 1955)
                            .Where(s => s.BirthDate.Year <= 1965)
                            //.Where(s => s.BirthDate.Year >= 1955 && s.BirthDate.Year <= 1965)
                            .Select(s => new
                            {
                                s.Last_Name,
                                s.Year_Result,
                                Category = s.Year_Result > 10 ? "Supérieur" : s.Year_Result == 10 ? "Neutre" : "Inférieur"
                            });

var result_3_2 = from Student s in dc.Students
                 where s.BirthDate.Year >= 1955 && s.BirthDate.Year <= 1965
                 select new {
                                s.Last_Name,
                                s.Year_Result,
                                Category = s.Year_Result > 10 ? "Supérieur" : s.Year_Result == 10 ? "Neutre" : "Inférieur"
                            };

foreach (var item in result_3_2)
{
    Console.WriteLine($"{item.Last_Name} {item.Year_Result} : {item.Category}");
}*/