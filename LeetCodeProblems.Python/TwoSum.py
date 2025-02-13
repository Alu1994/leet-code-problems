def twoSum(nums, target):
    map = {}
    for idx, x in enumerate(nums):
        complement = target - x
        if complement in map:
            return [idx, map[complement]]
        else:
            map[x] = idx
    return [0,0]

# res = TwoSum.twoSum([2,7,11,15], 9)