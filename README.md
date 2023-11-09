# Mod 1 Week 5 Assessment

## Questions (10 Points Possible)
1. What would happen if you try to use a variable that is not in scope?

- We will get computational and syntactic errors if we try and use variables that aren't within the scope we're working with. 

2. Describe the three As of a test:  
A -   Arrange - Set the world within the test the way that we want it to be. AKA build out all instances, variables, and method calls needed to run the test.
A -   Act - **EXECUTE** method we're trying to test.
A -   Assert - Verify that that what was supposed to be done, was.

3. What is the difference between `public` and `private` access modifiers?

The primary difference between the public and private access modifiers is that public allows for the code that the access modifier is describing to be accessable by all classes, where as the private access modifier only allows that same code to be accessed within the class it's written in.

4. A method should:  (**Select all that apply**) <br/>
(A) Make changes to an object  **<<<<**
(B) Return some information about an object **<<<<**  
(C) Make changes to an object and return information about the object.  
(D) None of the Above.  


5. How did you determine what to answer for the question above?

The answer that I selected for the above question is A and B. The primary reason is that a well written method will do one **OF** two things: give us information (AKA a query method), or change some information (AKA a command method). However, a well written method should only do one of these, which is why I didn't select answer C, which uses the keyword **AND**. I also didn't select D because I was able to select other answers. 

## Exercise (10 Points Possible)

Clone your forked copy of this repository into Visual Studio.  

In this solution, there is a User project with a single User class.  The class works, but it needs some additional effort to be great! One thing that is missing is tests; your job is to write the tests that will confirm the functionality of the class. Write one test for the constructor, and at least one test for each of the other 4 methods. As you write the tests, you might find some refactoring opportunities; update the user class with any refactors you deem necessary and add a comment describing why you made that refactor.  The only rule is that all the existing methods must still exist when you are finished!


## Submission

When finished:
* Commit your changes in Visual Studio
* Push up to GitHub
