--Kata Url : https://www.codewars.com/kata/511f11d355fe575d2c000001
--Solver : https://www.codewars.com/users/MrAliSalehi

local t = {}
function t.twoOldestAges(ages)
    table.sort(ages);
    return { ages[#ages - 1], ages[#ages]};
    
end
return t