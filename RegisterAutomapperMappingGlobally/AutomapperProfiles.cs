using AutoMapper;
using System.Reflection;

namespace RegisterAutomapperMappingGlobally
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            Func<Type, bool> typeFilterFunc = i => i.IsNotPublic == false && i.IsInterface == false;
            Assembly dtoAssembly = Assembly.Load("Registration.Dtos");
            Assembly modelsAssembly = Assembly.Load("Registration.Models");

            var dtoAssemblyTypes = dtoAssembly.GetTypes().Where(i => typeFilterFunc(i));
            var modelAssemblyTypes = modelsAssembly.GetTypes().Where(i => typeFilterFunc(i));


            var joinResult = (from dtoType in dtoAssemblyTypes
                             join modelDtoType in modelAssemblyTypes
                             on dtoType.Name equals modelDtoType.Name
                             select new
                             {
                                 dtoType,
                                 modelDtoType
                             }).ToList();
            foreach (var item in joinResult)
            {
               CreateMap(item.dtoType, item.modelDtoType).ReverseMap();
            }
        }

    }
}
