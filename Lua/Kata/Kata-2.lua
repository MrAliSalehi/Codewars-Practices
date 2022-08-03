--Kata Url : https://www.codewars.com/kata/5667e8f4e3f572a8f2000039
--Solver : https://www.codewars.com/users/MrAliSalehi

local solution = {}

function solution.accum(s)
    local returnResult = "";
    local charArray= {};
    local loopCounter = 0;

    local function multiplyString(char,times)
        local counter = 0;
        local outPut = "";
        while counter < times do
            outPut = outPut .. char;
            counter = counter + 1;
        end
        return outPut;
    end

    s:gsub(".",function(c) table.insert(charArray,c) end)
    
    for _,ch in ipairs(charArray) do

        returnResult = returnResult .. string.upper(ch);
        returnResult = returnResult .. string.lower(multiplyString(ch,loopCounter)) .. '-';

        loopCounter = loopCounter + 1;
    end
    
    return returnResult:sub(1,-2);
    end
  
return solution