--Kata Url : https://www.codewars.com/kata/52efefcbcdf57161d4000091
--Solver : https://www.codewars.com/users/MrAliSalehi

local kata = {}

function kata.count_chars(s)
    local result = {};
    local function Insert(c) 
        if (result[c] == nil) then
            result[c] = 1;
        else
            result[c] = result[c] + 1;
        end
    end

    s:gsub(".",Insert);

    return result;
end

return kata