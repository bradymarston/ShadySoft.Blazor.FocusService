// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.shadySoftFocusService = {
  setFocus: function (element) {
        console.log("Attempting to set focus.");
    element.focus();
  }
};
