// Example folders with images
const folders = [
    {
        title: "Album One",
        images: [
            "https://picsum.photos/400?random=11",
            "https://picsum.photos/400?random=12",
            "https://picsum.photos/400?random=13"
        ]
    },
    {
        title: "Album Two",
        images: [
            "https://picsum.photos/400?random=21",
            "https://picsum.photos/400?random=22",
            "https://picsum.photos/400?random=23"
        ]
    }
];

function openFolder(index) {
    const modal = document.getElementById("folderModal");
    const folderTitle = document.getElementById("folderTitle");
    const folderImages = document.getElementById("folderImages");

    folderTitle.textContent = folders[index].title;
    folderImages.innerHTML = folders[index].images
        .map(img => `<img src="${img}" class="rounded-xl shadow-md hover:scale-105 transition transform" />`)
        .join("");

    modal.classList.remove("hidden");
    modal.classList.add("flex");
}

function closeFolder() {
    const modal = document.getElementById("folderModal");
    modal.classList.add("hidden");
    modal.classList.remove("flex");
}