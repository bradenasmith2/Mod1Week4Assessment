# Mod1 Week4 Assessment
This assessment has two parts - some questions about this week's lessons, and an exercise focused on our Testing lesson. Work on the Questions first, then move on to the Exercise!

## Setup

Fork this repository!

## Questions (12 Points Possible)
Edit this `README.md` file - answer the BLANK questions before moving on to the exercise.  Make sure to SAVE your changes to the README before moving on!

1. Review the class definition below:
    ```c#
    public class Chair
    {
        public int Height { get; }
        public bool HasBack { get; }

        public Chair(int height, bool hasBack)
        {
            Height = height;
            HasBack = hasBack;
        }
    }
    ```
    Which of the following is NOT a valid way to create an instance of Chair? And why does this option not work?  
    A. `var bench = new Chair(24, true);`  yes
    B. `Chair bench = new Chair(24, true);`  yes
    C. `var bench = new(24, true);`  ***
    D. `Chair bench = new(24, true);`  yes
    
    *C. -> C is not correct as the variable doesn't know what data type it is. In the other examples it is explicitly stated that it is of type 'Chair', just in different ways.  
    
2. Imagine you are interviewing for your first job.  The interviewer asks "What can you tell me about OOP?".  Write your response below:

*Object-Oriented Programming consists of classes, and objects. Classes would be something of a category, for instance 'Book' could be a class, and its objects would be specific instances of books. OOP allows us to create blueprints or instuctions(methods) for our objects, which breaks our code up into digestible chunks as there is less repitition.

3. What is Automated Testing?

*Automated testing is a way for us to test specific aspects of our code such as classes, methods, properties, and more. It is a much more efficient, and informational way of testing compared to manual testing. Automated testing tells us exactly what is wrong, where it went wrong, and sometimes tells us how to fix it, providing an easier time for developers.

4. What are some benefits of creating tests for our projects?

*One major benefit of testing our projects is ruling out bugs. For instance, let's say I created a new list in a method, but I didn't test to ensure that the list was being generated properly. Once the code is ran, the program would break or provide an unexpected output that may or may not be caught.

5. When you create a test project, you do not immediately have access to the class(es) in the project that you are testing.  What do you need to do in order to have access to those classes?

*First, ensure everything you want to test is set to Public, then you need to add a project reference FROM your testing class TO your program class, and this will allow you to get the information inside the classes.

6. Take a look at the class below.  Write out the **names** of each test you would write to verify that this class is working.
```c#
    public class Vehicle
    {
        public int NumberOfWheels { get; }
        public string Color { get; private set;  }
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Sumary()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public void Drive()
        {
            MilesDriven += 5;
        }

        public void Paint(string newColor)
        {
            Color = newColor;
        }
    }
```

*Constructor_SetsCorrectValue_OfProperties()
*Sumary_Outputs_CorrectValues()
*Drive_AddsFive_To_MilesDriven_WithCorrectValue()
*Paint_Gets_NewColor_AndSets_ColorToNewColor()



## Exercise (8 Points Possible)
In Visual Studio, clone your forked repository.  
In this solution, there is a `Vehicle` project and a `Vehicle.UnitTests` project.  The class in `Vehicle.cs` is complete, but the tests for that class are not yet finished.  Add tests to the `VehicleTests.cs` file so that all the methods and properties for the `Vehicle` class have tests.  When finished, there should be a minimum of 4 tests (one is already completed for you!).

### Submission

When completed, commit the progress you have made, and push your project to GitHub.  Instructors will be following up with some video feedback!

### Rubric

This assessment has a total of **20 Points**.  Earning **10 or more** points is a **pass** and will indicate that you are progressing well with the material.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
