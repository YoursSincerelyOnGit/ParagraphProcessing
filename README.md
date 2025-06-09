* Task: I needed to create a method that takes a paragraph about Lodash, replaces "JavaScript" with "javascript", splits it into sentences using full stops, and logs the array to the console.
* Approach: I used Replace("JavaScript", "javascript") to modify the text and Split('.') to create an array of sentences, then printed each sentence using a foreach loop.
* Result: The code outputs two sentences with "javascript" in lowercase (see question2ResultsScreenshot.jpeg).
* Challenges: My initial code had a syntax error in the Split line, which I corrected to ensure proper sentence separation. Trimming whitespace from sentences could improve formatting.
* Source Code Reference: The method ModifyParagraph in OutputString.cs handles the replacement and splitting.
