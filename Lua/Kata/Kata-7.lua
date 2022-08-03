--Kata Url : https://www.codewars.com/kata/598d91785d4ce3ec4f000018
--Solver : https://www.codewars.com/users/MrAliSalehi

wordvalues = {}
function wordvalues.wordValues(arr)
    local alphabet = "abcdefghijklmnopqrstuvwxyz";

    local outPut = {};
    local positionOrder = 1;
    for _,word in ipairs(arr) do

        --remove whitespace
        word = word:gsub("%s+","");
        local totalValue = 0;
        for ch in word:gmatch(".") do totalValue = totalValue + alphabet:find(ch) end

        table.insert(outPut,totalValue * positionOrder)

        positionOrder = positionOrder + 1;
    end
    return outPut;
end
return wordvalues