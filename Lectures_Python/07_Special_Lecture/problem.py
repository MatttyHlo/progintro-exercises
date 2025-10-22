from collections import Counter

nums = input().split()
target = int(input())
nums = [int(x) for x in nums]
hashmap = Counter(nums)
num1 = 0
num2 = 0
for i in hashmap:
    if target - i == i:
        if hashmap[i] > 1:
            num1 = nums.index(i)
            nums[num1] = 0.1
            num2 = nums.index(i)
            print([num1, num2])
            break
        else:
            continue
    if target - i in hashmap:
        print([nums.index(i), nums.index(target - i)])
        break