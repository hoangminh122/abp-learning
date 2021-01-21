using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Permissions
{
    public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var myGroup = context.AddGroup(BookStorePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(BookStorePermissions.MyPermission1, L("Permission:MyPermission1"));

            var bookStoreGroup = context.AddGroup(BookStorePermissions.GroupName, L("Permission:BookStore"));

            var studentsPermission = bookStoreGroup.AddPermission(BookStorePermissions.Students.Default, L("Permission:Students"));
            studentsPermission.AddChild(BookStorePermissions.Students.Create,L("Permission:Books.Create"));
            studentsPermission.AddChild(BookStorePermissions.Students.Edit,L("Permission:Books.Edit"));
            studentsPermission.AddChild(BookStorePermissions.Students.Delete,L("Permission:Books.Delete")) ;


            //author
            var authorPermission = bookStoreGroup.AddPermission(BookStorePermissions.Authors.Default,L("Permission:Authors"));
            authorPermission.AddChild(
                BookStorePermissions.Authors.Create,L("Permission:Authors.Create"));

            authorPermission.AddChild(
               BookStorePermissions.Authors.Edit, L("Permission:Authors.Edit"));

            authorPermission.AddChild(
               BookStorePermissions.Authors.Delete, L("Permission:Authors.Delete"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookStoreResource>(name);
        }
    }
}
