using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WpfApp7.Rules;

namespace WpfApp7.Rules
{
    public class GroupDisciplineValidator
    {
        private List<GroupDisciplineRule> _rules;

        public GroupDisciplineValidator(string jsonFile)
        {
            string json = File.ReadAllText(jsonFile);
            _rules = JsonConvert.DeserializeObject<List<GroupDisciplineRule>>(json);
        }
        
            public bool IsGroupDisciplineValid(string selectedGroup, string selectedDiscipline)
            {
                foreach (GroupDisciplineRule rule in _rules)
                {
                    if (selectedGroup == null || selectedDiscipline  == null) continue;

                    List<string> groups = new List<string>();
                    List<string> discip = new List<string>();

                    if (rule.Group is JArray groupArray)
                    {
                        groups = groupArray.ToObject<List<string>>();
                    }
                    else if (rule.Group is string groupString)
                    {
                        groups.Add(groupString);
                    }

                    if (rule.Discipline is JArray discipArray)
                    {
                        discip = discipArray.ToObject<List<string>>();
                    }
                
                    if (groups.Any(group => string.Equals(group.Trim(), selectedGroup.Trim(), StringComparison.OrdinalIgnoreCase)) 
                        && discip.Any(discipline => string.Equals(discipline.Trim(), selectedDiscipline.Trim(), StringComparison.OrdinalIgnoreCase)))
                    {
                        return true;
                    }
                }
                return false;
            }
    }
}