// Заменить все вхождения подстроки w в строке st на строку v.
// Вывести на экран первоначальную строку и конечную строку


string st = "mama tyr ma mrar tmar";
string w = "ma";
string v = "pa";
string str = st.Replace(w, v);
Console.WriteLine(st);
Console.WriteLine(str);
