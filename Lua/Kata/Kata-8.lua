--Kata Url : https://www.codewars.com/kata/59ca8e8e1a68b7de740001f4
--Solver : https://www.codewars.com/users/MrAliSalehi

matchup = {}
function matchup.solve(a,b)
  local result = {};
    for _,word in ipairs(b)do
        local duplicatedCounter = 0;

        for _,word2 in ipairs(a) do
            if (word2 == word) then 
                duplicatedCounter = duplicatedCounter + 1;
            end
        end
        table.insert(result,duplicatedCounter);
    end
    return result;
 --code here
end
return matchup