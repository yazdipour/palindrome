wordlistfile = open("words.txt", "r")
wordlist = set()
reversedlist = set()

for line in wordlistfile:
    word = line.strip().lower()
    wordlist.add(word)
    reversedlist.add(word[::-1])

palindrome = wordlist & reversedlist
print(palindrome)
