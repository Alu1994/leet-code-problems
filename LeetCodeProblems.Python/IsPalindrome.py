def isPalindrome(self, x):
    valChar = str(x)
    indexStart = 0
    indexEnd = len(valChar) - 1
    while indexStart <= (len(valChar) / 2):
        if valChar[indexStart] != valChar[indexEnd]:
            return False            
        indexStart += 1
        indexEnd -= 1
    return True