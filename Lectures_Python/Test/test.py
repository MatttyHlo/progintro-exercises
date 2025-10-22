num1 = 0xFF
num2 = 0b1110000
print(bin(num1 | num2))

value = 5
if value & 0b0100:
    print("bit set")
else:
    print("bit not set")

print(2**10)