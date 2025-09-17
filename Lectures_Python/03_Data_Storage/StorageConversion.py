bytes = 1024464545555
kB = bytes / 1024
MB = kB / 1024
GB = MB / 1024
TB = GB /1024

print(bytes , "B")
print(kB , "kB")
print(MB , "MB")
print(GB , "GB")
print(TB , "TB")

GB = TB * 1024
MB = GB * 1024
kB = MB * 1024
bytes = kB *1024

print("---------------")
print(bytes , "B")
print(kB , "kB")
print(MB , "MB")
print(GB , "GB")
print(TB , "TB")