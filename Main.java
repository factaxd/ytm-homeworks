public class Main {
    public static void main(String[] args) {

        Lecturer lecturer1 = new Lecturer("Serdar");
        Lecturer lecturer2 = new Lecturer("Damla");

        BasicCourse programmingCourse = new BasicCourse("CS101", "Introduction to Programming", lecturer1);
        PracticalCourse algorithmsCourse = new PracticalCourse("CS102", "Algorithms and Data Structures", lecturer1);
        VocationalCourse databasesCourse = new VocationalCourse("CS103", "Database Management Systems", lecturer2);
        BasicCourse softwareEngineeringCourse = new BasicCourse("CS104", "Software Engineering", lecturer2);

        Student student1 = new Student("Ali", "12345");
        Student student2 = new Student("Salih", "67890");
        Student student3 = new Student("Mehmet", "54321");

        programmingCourse.enrollStudent(student1, 85);  
        algorithmsCourse.enrollStudent(student1, 78);   
        databasesCourse.enrollStudent(student1, 90);    
        softwareEngineeringCourse.enrollStudent(student1, 88);

        programmingCourse.enrollStudent(student2, 92);  
        algorithmsCourse.enrollStudent(student2, 88);   
        databasesCourse.enrollStudent(student2, 95);    
        softwareEngineeringCourse.enrollStudent(student2, 85);

        programmingCourse.enrollStudent(student3, 75);  
        algorithmsCourse.enrollStudent(student3, 82);   
        databasesCourse.enrollStudent(student3, 89);    
        softwareEngineeringCourse.enrollStudent(student3, 80);

  
        programmingCourse.printEnrolledStudents();
        algorithmsCourse.printEnrolledStudents();
        databasesCourse.printEnrolledStudents();
        softwareEngineeringCourse.printEnrolledStudents();


        System.out.println("\nAverage for " + programmingCourse.getCourseName() + ": " + programmingCourse.calculateAverage());
        System.out.println("Average for " + algorithmsCourse.getCourseName() + ": " + algorithmsCourse.calculateAverage());
        System.out.println("Average for " + databasesCourse.getCourseName() + ": " + databasesCourse.calculateAverage());
        System.out.println("Average for " + softwareEngineeringCourse.getCourseName() + ": " + softwareEngineeringCourse.calculateAverage());

        System.out.println("\nIndividual Student Course Info:");
        student1.printCourseInfo();
        student2.printCourseInfo();
        student3.printCourseInfo();
    }
}
