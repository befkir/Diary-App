# .Net CLI Doc
|  Purpose  | Command |
| :-- | :-- | 
|To Create gitignore file | ```bash dotnet new gitignore``` |
|To add diary migration | ```add-migration CreateDiaryEntryTable``` |
|To comit migrations to database | ``update-database`` |
|To seed diary migration | ```add-migration seedingDiary``` |
|To comit migrations to database | ```update-database``` |

# Bootstrap Doc
* [Bootstrap URL](https://bootswatch.com/journal/)
* Override the default bootstrap/dist/css/bootstrap.css content with the newly downloaded bootstrap.css
* Replace "bootstrap.min.css" with "bootstrap.css" on Views/Shared/_Layout.cshtml

# Client Side Validation
1. Add ```@section Scripts{<partial name="_ValidationScriptsPartial"/>}``` to the html
2. Add ```<span asp-validation-for="Title" class="text-danger"></span>``` to the form group
3. To show specific error message add anotation ErrorMessage inside parenthesis ```[Required(ErrorMessage ="Please enter a title!")]``` in the model
