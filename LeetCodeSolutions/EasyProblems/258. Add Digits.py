class Solution: 
    def Solve(self, num):
        while(num >= 10):
            sum = 0
            while(num > 0):
                sum += num % 10
                num //= 10
            num = sum

        return num

# debug
# sol = Solution()
# print(sol.Solve((38)))