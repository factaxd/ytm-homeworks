import java.util.ArrayList;
import java.util.List;

public class Student {
    private String name;
    private String studentId;
    private List<Course> courses;

    public Student(String name, String studentId) {
        this.name = name;
        this.studentId = studentId;
        this.courses = new ArrayList<>();
    }

    public String getName() {
        return name;
    }

    public String getStudentId() {
        return studentId;
    }

    public void enrollCourse(Course course, double grade) {
        courses.add(course);
        course.setStudentGrade(this, grade);
    }

    public List<Course> getCourses() {
        return courses;
    }


    public void printCourseInfo() {
        System.out.println("Student: " + name + " (ID: " + studentId + ")");
        for (Course course : courses) {
            System.out.println("Course: " + course.getCourseName() + " - Grade: " + course.getStudentGrade(this) + 
                " - Letter Grade: " + course.getLetterGrade(this));
        }
    }
}
