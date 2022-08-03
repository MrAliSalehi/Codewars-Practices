--Kata Url : https://www.codewars.com/kata/55c45be3b2079eccff00010f
--Solver : https://www.codewars.com/users/MrAliSalehi

function order(words)
  local wordArray = {  };
    local tableLen = 0;
    for word in words:gmatch("%S+") do
        local number = word:match("%d+");
        wordArray[number] = word;
        tableLen = tableLen + 1;
    end
    table.sort(wordArray);

    local fixedString = "";
    local counter = 1;
    while counter <= tableLen do
        fixedString = fixedString .. wordArray[tostring(counter)] .. " ";
        counter = counter + 1;
    end


    return fixedString:sub(1,-2);
end