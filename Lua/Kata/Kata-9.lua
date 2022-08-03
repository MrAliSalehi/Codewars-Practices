--Kata Url : https://www.codewars.com/kata/59df2f8f08c6cec835000012
--Solver : https://www.codewars.com/users/MrAliSalehi

function Test(s)
    table.sort(s);  
    return  s;
end


local a = Test({"b","a","fwa"})
for _,x in ipairs(a) do
print(x)
end 