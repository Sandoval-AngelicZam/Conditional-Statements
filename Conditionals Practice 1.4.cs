

/*Practice 1.4 */

Console.Write("Enter the students score: ");
int score = Convert.ToInt32(Console.ReadLine());

string result = (score >= 50) ? "Great you passed the exam!" : "You failed! Better luck next time";
Console.WriteLine(result);
