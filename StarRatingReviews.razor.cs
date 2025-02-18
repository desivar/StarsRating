.reviews ::deep textarea {
    display: block;
    padding: 6px 8px;
    margin-bottom: 5px;
    width: 100%;
    border: 1px solid #605E5C;
    border-radius: 2px;
    font-family: Open Sans, sans-serif;
    font-size: 0.8em;
    color: #605E5C;
    box-sizing: border-box;
}

.reviews ::deep .rating {
    display: none;
}

.review-editor {
    margin-bottom: 10px;
}

button {
    padding: 6px 25px;
    font-family: Playfair Display;
    color: white;
    background-color: #435869;
    border-radius: 2px;
    border: 0;
}

    button:hover {
        background-color: #334452;
    }

    button:active {
        background-color: #26343f;
    }

::deep input.invalid, ::deep textarea.invalid, ::deep div.invalid {
    border: 1px solid red;
}

::deep .validation-errors {
    color: red;
    font-size: 0.8em;
}