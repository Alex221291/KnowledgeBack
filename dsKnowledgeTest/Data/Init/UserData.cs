using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Models;

namespace dsKnowledgeTest.Data.Init
{
    public static class UserData
    {
        public static readonly User Administrator = new()
        {
            Id = Guid.NewGuid(),
            FirstName = "Николай",
            SurName = "Викторович",
            LastName = "Степанов",
            Organization = "ООО ДримСофт",
            Specialization = "Администратор",
            Email = "administrator@gmail.com",
            Password = "25D55AD283AA400AF464C76D713C07AD",
            PhoneNumber = "+375293331648",
            Login = "administrator",
            IconUrl = null,
            DataCreated = DateTime.UtcNow,
            DataUpdated = DateTime.UtcNow,
            Role = RolesConst.Admin,
            IsActivated = true,
            IsDeleted = false
        };
    }
}
