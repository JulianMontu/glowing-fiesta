import { Component } from '@angular/core';
@Component({
    selector: 'chat-app',
    templateUrl: "./chat.component.html"
})
export class chatComponent {
    public name = 'Julian'
    public newName() {
        this.name = "Julian.net" 
    }

}
