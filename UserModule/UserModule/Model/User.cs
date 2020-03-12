﻿namespace UserModule.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public User(int id,string name,string email,string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
        }
        public User Update(string name,string address) {

            Name = name;
            Address = address;
            return this;
        }
    }
}
