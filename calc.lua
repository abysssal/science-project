-- To run, do CTRL+SHIFT+B 
x = 20
y = 65
z = 234.43878
ans = 0

print("Here a couple variables used:")
print("x is 20")
print("y is 65")
print("z is 234.43878")

print("We are looking for approximately 7000")

print("Starting the calculations in Lua..")
print("x = x * 4")
x = x * 4
print("x equals " .. x)
    ;
print("x = y / 25.2842")
x = y / 25.2842
print("x is " .. x)
    
print("y = x * 23")
y = x * 23
print("y is " .. y)
    
print("y = y * z / x")
y = y * z / x
print("y is " .. y)
    
print("z = z * (x + 5 - 0.2432)")
z = z * (x + 5 - 0.2432)
print("z is " .. z)
    
print("z = z + y + x")
z = z + y + x
print("z is " .. z)
    
ans = z
print("Our answer is..")
print(ans .. "!")
