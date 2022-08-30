Debugging
   The .NET application in the Solution folder contains an error that causes it to print incorrect results when run.
   Find the bug with the StatusService and repair it.

 Requirements:
   You'll need Visual Studio, Visual Studio Code, Project Rider, or another C# compatible IDE for this question.

 Architecture:
   Model
       These classes represent the data objects used by the Program.
   Repos
       These interfaces and their implementations are used to query the data sources.
   Services
       These interfaces and their implementations contain the business logic used for specific operations.

 Summary:
   The purpose of this system is to define a set of valid states called Statuses and their behaviors.
   For this system each Status's behavior will be defined by a Transition.  A Transition allows the system to
   identify which behavior is valid for a specific status.
   Each Transition is further filtered by a Subtype.  A Transition can only be valid for a single Subtype at a time.

   One important requirement of the system is to know which Status objects are Initial Statuses.
   If a Transition object has a null FromStatus property, the ToStatus value of that Transition is an Initial Status.
   
   The purpose of this specific Program is to return all Statuses for each Subtype that are defined as Initial Statuses.
   These initial Statuses will need to be grouped and displayed by Subtype.

   The Program provided should run and currently gives an example output which is incorrect for the defined Status, Transition and Subtype
   objects.  Please debug the Program and correct the logic to provide the correct output.