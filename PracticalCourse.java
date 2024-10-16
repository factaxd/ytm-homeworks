public class PracticalCourse extends Course {
    public PracticalCourse(String courseCode, String courseName, Lecturer lecturer) {
        super(courseCode, courseName, lecturer);
    }

   
    public void printEnrolledStudents() {
        System.out.println("Students Enrolled in Practical Course: " + getCourseName());
        for (Student student : getStudents()) {
            System.out.println("Student: " + student.getName() + " - Grade: " + getStudentGrade(student) + 
                " - Letter Grade: " + getLetterGrade(student));
        }
    }

    @Override
    public double calculateAverage() {
        double total = 0;
        int count = getStudents().size();
        
        for (Student student : getStudents()) {
            total += getStudentGrade(student);
        }
        
        return count == 0 ? 0 : total / count;
    }
}
