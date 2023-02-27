// See https://aka.ms/new-console-template for more information

using GenericExample;

Repository<User> users = new();
Repository<Note> notes = new();

List<User> filteredUsers = users.Filter(u => u.Login == "admin");

List<Note> filteredNotes = notes.Filter(n => n.CreateDate > new DateTime(2022, 2, 27));

Console.WriteLine("Hello, World!");