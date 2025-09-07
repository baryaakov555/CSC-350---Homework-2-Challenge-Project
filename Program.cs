using System;

int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];

string currectStudentLetterGrade = "";

Console.WriteLine("Student\t\tAverage Exam Scores\t\tOverall Grade\t\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumOfAssignmentScores = 0;
    decimal aveageOfExamScores = 0;
    decimal sumOfExtraCredits = 0;
    decimal ExtraCreditsBonusPoints = 0;
    decimal overAllGrade = 0;

    int assignmentNumber = 0;

    foreach (int score in studentScores)
    {
        assignmentNumber += 1;

        if (assignmentNumber <= examAssignments)
        {
            sumOfAssignmentScores += score;
        }
        else
        {
            sumOfExtraCredits += (decimal)score / 10;
        }
    }

    aveageOfExamScores = (decimal)sumOfAssignmentScores / examAssignments;

    ExtraCreditsBonusPoints = sumOfExtraCredits / examAssignments;

    overAllGrade = aveageOfExamScores + ExtraCreditsBonusPoints;

    if (overAllGrade >= 97)
        currectStudentLetterGrade = "A+";
    else if (overAllGrade >= 93)
        currectStudentLetterGrade = "A";
    else if (overAllGrade >= 90)
        currectStudentLetterGrade = "A-";
    else if (overAllGrade >= 87)
        currectStudentLetterGrade = "B+";
    else if (overAllGrade >= 83)
        currectStudentLetterGrade = "B";
    else if (overAllGrade >= 80)
        currectStudentLetterGrade = "B-";
    else if (overAllGrade >= 77)
        currectStudentLetterGrade = "C+";
    else if (overAllGrade >= 73)
        currectStudentLetterGrade = "C";
    else if (overAllGrade >= 70)
        currectStudentLetterGrade = "C-";
    else if (overAllGrade >= 67)
        currectStudentLetterGrade = "D+";
    else if (overAllGrade >= 63)
        currectStudentLetterGrade = "D";
    else if (overAllGrade >= 60)
        currectStudentLetterGrade = "D-";
    else
        currectStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{aveageOfExamScores}\t\t\t\t{overAllGrade}  ||  {currectStudentLetterGrade}\t\t{aveageOfExamScores} ({ExtraCreditsBonusPoints} pts)");
}

Console.ReadLine();