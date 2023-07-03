# Modal bug repro

1. start on a normal page in a Shell app (default PresentationMode)
1. navigate to a **modal** `ContentPage` (`PresentationMode` is `ModalAnimated`) --> no title bar is shown - **bug 1**
1. from that modal `ContentPage`, navigate to a new **normal (non-modal)** `ContentPage` (`PresentationMode` is `Animated` (default)) --> it is opened with a modal animation (slide from the bottom) instead of a normal page navigation animation (slide from the right) AND still there is no title bar so you cannot navigate back to the first modal page using a back button - **bug 2**
1. from the should-be non-modal page, navigate to a non-modal page --> it keeps being opened as a modal page (slide from the bottom) - **bug 2**

Bug 1 - no title bar is shown for modal pages
Bug 2 - non-modal pages navigated to from a modal page keep being presented and animated as modal pages
