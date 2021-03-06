// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;

namespace Microsoft.Azure.Search.Models
{
    /// <summary>
    /// Parameters for filtering, sorting, fuzzy matching, and other
    /// suggestions query behaviors.
    /// </summary>
    public partial class SuggestParameters
    {
        private string _filter;
        
        /// <summary>
        /// Optional. Gets or sets the OData $filter expression to apply to the
        /// suggestions query.  (see
        /// https://msdn.microsoft.com/library/azure/dn798921.aspx for more
        /// information)
        /// </summary>
        public string Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }
        
        private string _highlightPostTag;
        
        /// <summary>
        /// Optional. Gets or sets a string tag that is appended to hit
        /// highlights. Must be set with HighlightPreTag. If omitted, hit
        /// highlighting of suggestions is disabled.
        /// </summary>
        public string HighlightPostTag
        {
            get { return this._highlightPostTag; }
            set { this._highlightPostTag = value; }
        }
        
        private string _highlightPreTag;
        
        /// <summary>
        /// Optional. Gets or sets a string tag that is prepended to hit
        /// highlights. Must be set with HighlightPostTag. If omitted, hit
        /// highlighting of suggestions is disabled.
        /// </summary>
        public string HighlightPreTag
        {
            get { return this._highlightPreTag; }
            set { this._highlightPreTag = value; }
        }
        
        private double? _minimumCoverage;
        
        /// <summary>
        /// Optional. Gets or sets a number between 0 and 100 indicating the
        /// percentage of the index that must be covered by a suggestion query
        /// in order for the query to be reported as a success. This parameter
        /// can be useful for ensuring search availability even for services
        /// with only one replica. The default is 80.
        /// </summary>
        public double? MinimumCoverage
        {
            get { return this._minimumCoverage; }
            set { this._minimumCoverage = value; }
        }
        
        private IList<string> _orderBy;
        
        /// <summary>
        /// Optional. Gets or sets the list of OData $orderby expressions by
        /// which to sort the results. Each expression can be either a field
        /// name or a call to the geo.distance() function. Each expression can
        /// be followed by asc to indicate ascending, and desc to indicate
        /// descending. The default is ascending order. Ties will be broken by
        /// the match scores of documents. If no OrderBy is specified, the
        /// default sort order is descending by document match score. There
        /// can be at most 32 Orderby clauses.
        /// </summary>
        public IList<string> OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }
        
        private IList<string> _searchFields;
        
        /// <summary>
        /// Optional. Gets or sets the list of field names to consider when
        /// querying for suggestions.
        /// </summary>
        public IList<string> SearchFields
        {
            get { return this._searchFields; }
            set { this._searchFields = value; }
        }
        
        private IList<string> _select;
        
        /// <summary>
        /// Optional. Gets or sets the list of fields to retrieve. If
        /// unspecified, all fields marked as retrievable in the schema are
        /// included.
        /// </summary>
        public IList<string> Select
        {
            get { return this._select; }
            set { this._select = value; }
        }
        
        private int? _top;
        
        /// <summary>
        /// Optional. Gets or sets the number of suggestions to retrieve. This
        /// must be a value between 1 and 100. The default is to 5.
        /// </summary>
        public int? Top
        {
            get { return this._top; }
            set { this._top = value; }
        }
        
        private bool _useFuzzyMatching;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether to use fuzzy
        /// matching for the suggestion query. Default is false. when set to
        /// true, the query will find suggestions even if there's a
        /// substituted or missing character in the search text. While this
        /// provides a better experience in some scenarios it comes at a
        /// performance cost as fuzzy suggestion searches are slower and
        /// consume more resources.
        /// </summary>
        public bool UseFuzzyMatching
        {
            get { return this._useFuzzyMatching; }
            set { this._useFuzzyMatching = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SuggestParameters class.
        /// </summary>
        public SuggestParameters()
        {
            this.OrderBy = new LazyList<string>();
            this.SearchFields = new LazyList<string>();
            this.Select = new LazyList<string>();
        }
    }
}
