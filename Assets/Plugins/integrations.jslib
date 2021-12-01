// Boilerplate
mergeInto(LibraryManager.library, {

    SetScore: function(score) {
        window.dispatchEvent(new CustomEvent('score', { detail: { score } }));
    }

});