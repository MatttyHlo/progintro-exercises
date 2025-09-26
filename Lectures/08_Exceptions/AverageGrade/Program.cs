int[] grades = {4, 7, 02, 00, 10, 4, 12};

int GetGrade(int courseid, int[] grades){
    int grade = grades[courseid];

    if(grade <= 2)throw new Exception("Failing grade");
    else return grade;
}
int count = 0;
int sum = 0;
int grade;
for(int courseid = 0; courseid < grades.Length; courseid++){
    try{
        grade = GetGrade(courseid, grades);
    }
    catch {continue;}
    count++;
    sum += grade;

}
Console.WriteLine((double)sum/count);
