num = int(input())
twos = (3 - num % 3) % 3
threes = (num - 2 * twos)//3
output = ""
print(twos+ threes)
for i in range(twos):
    output += "2 "
for i in range(threes):
    output += "3 "
print(output)