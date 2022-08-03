--Kata Url : https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d
--Solver : https://www.codewars.com/users/MrAliSalehi

kata = {}

function kata.strEndsWith(s, ending)
   return ending == "" or s:sub(-#ending) == ending
  
end

return kata