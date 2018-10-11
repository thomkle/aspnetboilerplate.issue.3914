# aspnetboilerplate.issue.3914
Reproducing issue with aspnetboilerplate (issue number 3914).

Build the Top and Middle solutions before you open Bottom and make sure the references to Top.Web.Resources.Embedded and Middle.Web.Resources.Embedded are added before you run Bottom.Web.

The result you will see is that the "Middle_Hello" key is not resolved, while the other keys are.
