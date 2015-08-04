using System;
using Sputnik.Models.ApplicationUnderTest;

namespace Sputnik.Models.BaseModels
{
    public class PageElement : SeleniumPage
    {
        /// <summary>
        /// This holds the value of the chosen selector. It will be empty if the selector used is NOT selecting the item on the page using the "id" attribute of the DOM element
        /// </summary>
        protected string chosenSelectorById = string.Empty;

        /// <summary>
        /// Will be empty if the selector is NOT using the CssPath of the DOM element to retrieve the element from the GUI
        /// </summary>
        protected string chosenSelectorByCssPath = string.Empty;

        /// <summary>
        /// Will be empty if the selector is NOT executing a jQueyr script in order to retrieve the GUI element
        /// </summary>
        private string chosenSelectorByJquery = string.Empty;

        /// <summary>
        /// Basic constructor, will populate the id selector
        /// </summary>
        /// <param name="idSelector">Selector to use when grabbing elements by Id</param>
        public PageElement(string idSelector)
        {
            chosenSelectorById = idSelector;
        }

        /// <summary>
        /// This constructor takes in two selectors, but it really cares only about the second selector.
        /// </summary>
        /// <param name="idSelector">Will always be empty in this constructor. To use select by "id" use the first constructor</param>
        /// <param name="cssPathSelector">This will be populate with the given second parameter</param>
        public PageElement(string idSelector, string cssPathSelector)
        {
            this.chosenSelectorById = string.Empty;
            this.chosenSelectorByCssPath = cssPathSelector;
        }

        /// <summary>
        /// This constructor takes three selectors, but it really cares only about the third selector.
        /// </summary>
        /// <param name="idSelector">Will be set to empty</param>
        /// <param name="cssPathSelector">Will be to empty</param>
        /// <param name="jQuerySelector">Will be set to whatever value is passed to the constructor</param>
        public PageElement(string idSelector, string cssPathSelector, string jQuerySelector)
        {
            this.chosenSelectorById = string.Empty;
            this.chosenSelectorByCssPath = string.Empty;
            this.chosenSelectorByJquery = jQuerySelector;
        }

        /// <summary>
        /// This is the method that will click on the page, it will figure out what selector to use based on which selector is not empty.
        /// </summary>
        public void Click()
        {
            if (chosenSelectorById != string.Empty)
            {
                ClickCommand.ById(chosenSelectorById);
            }
            else if (chosenSelectorByCssPath != string.Empty)
            {
                ClickCommand.ByCssPath(chosenSelectorByCssPath);
            }
            else if (chosenSelectorByJquery != string.Empty)
            {
                ClickCommand.ByJquery(chosenSelectorByJquery);
            }
        }

        /// <summary>
        /// This is the method that will set values on the page, it will figure out what selector to use based on which selector is not empty.
        /// </summary>
        public void Set(string valueToSet)
        {
            if (chosenSelectorById != string.Empty)
            {
                SetCommand.ById(chosenSelectorById, valueToSet);
            }
            else if (chosenSelectorByCssPath != string.Empty)
            {
                // TODO: Add this feature
                //SetCommand.ByCssPath(chosenSelectorByCssPath);
            }
        }

        /// <summary>
        /// This is the method that will set values on the page, it will figure out what selector to use based on which selector is not empty.
        /// </summary>
        public void SetPostBackDropdown(string valueToSet)
        {
            if (chosenSelectorById != string.Empty)
            {
                SetCommand.ById(chosenSelectorById, valueToSet);
                SubmitCommand.ById(chosenSelectorById);
            }
            else if (chosenSelectorByCssPath != string.Empty)
            {
                //SetCommand.ByCssPath(chosenSelectorByCssPath);
            }
        }

        /// <summary>
        /// This is the method that verify values on the page, it will figure out what selector to use based on which selector is not empty.
        /// </summary>
        public void IsNot(string valueToCompareWith)
        {
            if (chosenSelectorById != string.Empty)
            {
                base.IsNotCommand.ById(chosenSelectorById, valueToCompareWith);
            }
            if (chosenSelectorByCssPath != string.Empty)
            {
                base.IsNotCommand.ByCssPath(chosenSelectorByCssPath, valueToCompareWith);
            }
            if (chosenSelectorByJquery != string.Empty)
            {
                base.IsNotCommand.ByJQuery(chosenSelectorByJquery, valueToCompareWith);
            }
        }

        /// <summary>
        /// This is the method that verify values on the page, it will figure out what selector to use based on which selector is not empty.
        /// </summary>
        public bool Is(string valueToCompareWith)
        {
            if (chosenSelectorById != string.Empty)
            {
                base.IsCommand.ById(chosenSelectorById, valueToCompareWith);
            }
            if (chosenSelectorByCssPath != string.Empty)
            {
                base.IsCommand.ByCssPath(chosenSelectorByCssPath, valueToCompareWith);
            }
            if (chosenSelectorByJquery != string.Empty)
            {
                base.IsCommand.ByJQuery(chosenSelectorByJquery, valueToCompareWith);
            }

            // If both selectors are empty then automatically fail the Fact
            return false;
        }

        /// <summary>
        /// This is the method that verify that some values exist within a page, it will figure out what selector to use based on which selector is not empty.
        /// </summary>
        public bool Like(string valueToCompareWith)
        {
            if (chosenSelectorById != string.Empty)
            {
                return base.LikeCommand.ById(chosenSelectorById, valueToCompareWith);
            }
            if (chosenSelectorByCssPath != string.Empty)
            {
                return base.LikeCommand.ByCssPath(chosenSelectorByCssPath, valueToCompareWith);
            }
            if (chosenSelectorByJquery != string.Empty)
            {
                return base.LikeCommand.ByJQuery(chosenSelectorByJquery, valueToCompareWith);
            }

            // If both selectors are empty then automatically fail the Fact
            return false;
        }

        /// <summary>
        /// This is the method that verifies that a element exists in the DOM - regardless of whether it's visible or not
        /// </summary>
        public void NotExist()
        {
            if (chosenSelectorById != string.Empty)
            {
                base.NotExistCommand.ById(chosenSelectorById);
            }
            if (chosenSelectorByCssPath != string.Empty)
            {
                base.NotExistCommand.ByCssPath(chosenSelectorByCssPath);
            }
            if (chosenSelectorByJquery != string.Empty)
            {
                base.NotExistCommand.ByJQuery(chosenSelectorByJquery);
            }
        }

        /// <summary>
        /// This is the method that verifies that a element exists in the DOM - regardless of whether it's visible or not
        /// </summary>
        public void Exist()
        {
            if (chosenSelectorById != string.Empty)
            {
                base.ExistCommand.ById(chosenSelectorById);
            }
            if (chosenSelectorByCssPath != string.Empty)
            {
                base.ExistCommand.ByCssPath(chosenSelectorByCssPath);
            }
            if (chosenSelectorByJquery != string.Empty)
            {
                base.ExistCommand.ByJQuery(chosenSelectorByJquery);
            }
        }

        /// <summary>
        /// This method checks if an element is not visible in the dom.
        /// </summary>
        public void NotVisible()
        {
            if (chosenSelectorById != string.Empty)
            {
                base.NotVisibleCommand.ById(chosenSelectorById);
            }
            if (chosenSelectorByCssPath != string.Empty)
            {
                base.NotVisibleCommand.ByCssPath(chosenSelectorByCssPath);
            }
            if (chosenSelectorByJquery != string.Empty)
            {
                base.NotVisibleCommand.ByJQuery(chosenSelectorByJquery);
            }
        }

        /// <summary>
        /// This method checks if an element is visible in the dom.
        /// </summary>
        public void Visible()
        {
            if (chosenSelectorById != string.Empty)
            {
                base.VisibleCommand.ById(chosenSelectorById);
            }
            if (chosenSelectorByCssPath != string.Empty)
            {
                base.VisibleCommand.ByCssPath(chosenSelectorByCssPath);
            }
            if (chosenSelectorByJquery != string.Empty)
            {
                base.VisibleCommand.ByJQuery(chosenSelectorByJquery);
            }
        }
    }
}