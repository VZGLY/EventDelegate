using EventDelegate;

Société maSociété = new Société();

User user1 = new User();

user1.Email = "lalala@gmail.Com";


User user2 = new User();

user2.Email = "lololo@gmail.Com";

maSociété.Users.Add(user1);
maSociété.Users.Add(user2);


maSociété.AjouterNudes(user1);
maSociété.AjouterNoreplay(user1);
maSociété.AjouterNoreplay(user2);

maSociété.SendMails();