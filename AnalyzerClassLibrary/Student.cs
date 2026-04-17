public class Student
{
    public int ID { get; set; }
    public string FullName { get; set; }
    public int Course { get; set; }
    public string Group { get; set; }
    public double Physics { get; set; }
    public double English { get; set; }
    public double History { get; set; }
    public double PhysicalEducation { get; set; }
    public double CulturalStudies { get; set; }
    public double Informatics { get; set; }
    public double Psychology { get; set; }
    public double Mathematics { get; set; }
    public double Biology { get; set; }
    public double Chemistry { get; set; }
    public double AverageGrade { get; set; }
    public int DebtCount { get; set; }
    public Student(int id, string fullName, int course, string group, double physics, 
        double english, double history, double pe, double cs, double inf, double psychology, double math,
        double bio, double chemistry, double average, int debt)
    {
        ID = id;
        FullName = fullName;
        Course = course;
        Group = group;
        Physics = physics;
        English = english;
        History = history;
        PhysicalEducation = pe;
        CulturalStudies = cs;
        Informatics = inf;
        Psychology = psychology;
        Mathematics = math;
        Biology = bio;
        Chemistry = chemistry;
        AverageGrade = average;
        DebtCount = debt;
    }
}