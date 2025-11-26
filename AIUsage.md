# Use of Generative AI

**AI Tool Used:** Comet Assistant, Claude (Sonnet 4.5)

## Exercise 1
- I used Comet to search for a format for PR review as a separate file, because I only had experience writting PR feedback on github before.
- After listing out the issues I've noticed, I gave my work to Claude to check if I have covered everything. Claude gave me a few more changes I should suggest and I modified my file based on its feedback, this includes:
Line 44: Random number generation only gives 0, which makes the function never add "Betty".
Line 64: Current method returns people younger than 30 instead of older with ">="
Line 13: Inconsistent type name for DateTimeOffset.
Line 39-58: Try-catch is not necessary since the operation is unlikely to fail. 
Line 62-65: Method GetBobs is never used internally.
Line 7: Class name "People" is plural which doesn't serve the purpose of the class for a single person.
Line 9: "Under16" is a confusing constant name and it doesn't describe the purpose clearly.

## Exercise 2
- After finishing writing my own UpdateQuality method, I gave my code to Claude to check if I have covered everything right. Claude found a few issues for me and I changed them based on its feedback, this includes:
I didn't implement else statement after if for some loops, which would make the method process both conditions.
Using System.Math.Min(item.Quality + 2, 50) to do quality modification instead of using simple plus or minus, it is a better approach because it prevents item's quality to exceed 50 or go below 0 without using too many if statements which would make the code look confusing. 

