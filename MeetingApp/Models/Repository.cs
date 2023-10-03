using Microsoft.VisualBasic;

namespace MeetingApp.Models
{
     public  class Repository
     {
        private static List<UserInfo>_users=new();
        
          static Repository()
          {
              _users.Add(new UserInfo(){Id=1,  Name="Ali",Email="Abc@gmail.com",Phone="1111111111",WillAttend=true});
              _users.Add(new UserInfo(){Id=2, Name="Ahmet",Email="Ahmet@gmail.com",Phone="1111111111",WillAttend=false});
              _users.Add(new UserInfo(){
               Id=3, Name="Ayşe",Email="Ayşe@gmail.com",Phone="1111111111",WillAttend=true});
          }
         public static List<UserInfo> Users{
                get {
                    return _users;
                }
         }
            
         public static void CreateUser(UserInfo user)
         {
                user.Id=Users.Count+1;
              _users.Add(user);
         }
     
         public static UserInfo? GetById(int Id)
         {
             return _users.FirstOrDefault(user=>user.Id==Id);
         }
         
     }

}