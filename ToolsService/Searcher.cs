using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locnes.ToolsService
{
    public static class Searcher
    {
        private static List<SearchListing> listings = new List<SearchListing>() { }; 
        
        private static void GenerateListings()
        {
            if(listings.Count != 0) { return; }

            foreach (SearchQuery _query in (SearchQuery[])Enum.GetValues(typeof(SearchQuery)))
            {
                var _listing = new SearchListing() { Label = Enum.GetName(_query).Replace("_", " > "), Query = _query };
                listings.Add(_listing);
            }
        }

        public static SearchListing[] FindMatchesSafe(string query)
        {
            GenerateListings();
            
            List<SearchListing> _matches = new List<SearchListing>() { };
            char[] _hier = query.ToCharArray();
            foreach (SearchListing _l in listings) {
                foreach(char _c in _hier) {
                    if(_l.Label.Contains(_c)) {
                        _matches.Add(_l); } } }
            return _matches.ToArray();
        }

        public static bool QuerytoAction(SearchQuery search)
        {
            switch(search)
            {
                case SearchQuery.FILE_EXIT: Actions.ExitApp(); break;
                case SearchQuery.VIEW_TOGGLESEARCHER: Editeur.instance.ToggleSearcher(); break;
                default: return false;
            }
            return true;
        }
    }

    public enum SearchQuery
    {
        FILE_OPENFOLDER,
        FILE_OPEN,
        FILE_SAVE,
        FILE_SAVEAS,
        FILE_EXIT,

        VIEW_TOGGLESEARCHER
    }

    public class SearchListing
    {
        public string Label;
        public SearchQuery Query;
    }
}
