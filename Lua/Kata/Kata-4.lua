--Kata Url : https://www.codewars.com/kata/51f2b4448cadf20ed0000386
--Solver : https://www.codewars.com/users/MrAliSalehi

return {
  removeUrlAnchor = function(s)
    local index = string.find(s,'#') or string.find(s,'?');
    if (index == nil)then 
      return s;
    end
    
    return string.sub(s,1, index - 1);
  end
}