public class Solution {
    public char RepeatedCharacter(string s) {
        char[] characters = new char[26];
        foreach(var c in s) {
            if (characters[c % 26] != c) {
                characters[c % 26] = c;
            }
            else if (characters[c % 26] == c) {
                return c;
            }
        }
        return ' ';
    }
}