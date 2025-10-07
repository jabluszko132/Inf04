import random

def drawRandom(nOfDraws: int) -> list:
    draws = []
    for i in range(nOfDraws):
        newDraw = []
        for j in range(6):
            while True:
                newNum = random.randint(1,49)
                if newNum not in newDraw:
                    newDraw.append(newNum)
                    break
        draws.append(newDraw)
    return draws

def printDraws(draws: list) -> None:
    print("Zestawy wylosowanych liczb:")
    for i in range(len(draws)):
        print(f"Losowanie {i + 1}: {str(draws[i])[1:-1].replace(',',' ')}")

def countNums(draws: list) -> list:
    nums = [0 for i in range(49)]
    for draw in draws:
        for num in draw:
            nums[num - 1] += 1
    return nums


nOfDraws = int(input("Ile wygenerować losowań?\n"))
draws = drawRandom(nOfDraws)
printDraws(draws)
countedNums = countNums(draws)
for i in range(49):
    print(f"Wystąpienia liczby {i + 1}: {countedNums[i]}")