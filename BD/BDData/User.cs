namespace BD
{
    class User
    {
        public int Id { get; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public int Full_Age { get; set; }
        public int RoleId { get; set; }

        public User(int id, string name, string nickname, int fullage, int roleid)
        {
            Id = id;
            Name = name;
            NickName = nickname;
            Full_Age = fullage;
            RoleId = roleid;
        }
    }
}
