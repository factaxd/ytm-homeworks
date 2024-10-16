import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public abstract class Course {
    private String courseCode;
    private String courseName;
    private Lecturer lecturer;
    private List<Student> students;
    private Map<Student, Double> studentGrades;

    public Course(String courseCode, String courseName, Lecturer lecturer) {
        this.courseCode = courseCode;
        this.courseName = courseName;
        this.lecturer = lecturer;
        this.students = new ArrayList<>();
        this.studentGrades = new HashMap<>();
    }

    public String getCourseCode() {
        return courseCode;
    }

    public String getCourseName() {
        return courseName;
    }

    public Lecturer getLecturer() {
        return lecturer;
    }

    public void enrollStudent(Student student, double grade) {
        students.add(student);
        studentGrades.put(student, grade);
    }

    public List<Student> getStudents() {
        return students;
    }

    public void setStudentGrade(Student student, double grade) {
        studentGrades.put(student, grade);
    }

    public Double getStudentGrade(Student student) {
        return studentGrades.get(student);
    }

    public String getLetterGrade(Student student) {
        Double grade = getStudentGrade(student);
        if (grade == null) return "No Grade";
        
        if (grade >= 85) return "AA";
        else if (grade >= 70) return "BB";
        else if (grade >= 60) return "CC";
        else if (grade >= 45) return "DD";
        else return "FF";
    }


    public abstract double calculateAverage();
}
