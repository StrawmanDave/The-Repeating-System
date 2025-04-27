# The-Repeating-System
This is for the Challenge The Repeating System in C# Players Guide Fifth Edition on page 349

Objectives:
Make a RecentNumbers class that holds at least the two most recent numbers.

Make a method that loops forever, generating, random numbers from 0 to 9 once a second.
Hint: Thread.Sleep can help you wait.

Write the numbers to the console window, put the generated numbers in a RecentNumbers object, and update it as new numbers are generated.

Make a thread that runs the above method.

Wait for the user to push a key in a second loop(on the main thread or another new thread.)
When the user presses a key, check if the last two numbers are the same. If they are, tell the user that they correctly identified the repeat.
If they are not, indicate that they got it wrong.

Use lock statements to ensure that only one thread accesses the shared data at a time.