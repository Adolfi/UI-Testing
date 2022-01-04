describe('When visiting post page', () => {
    it('Then verify post page is accessible', () => {
        cy.visit('https://adolfi.dev/blog/site-variables-in-umbraco-9/');        
    });

    it('Then verify expected post title', () => {
        cy.visit('https://adolfi.dev/blog/site-variables-in-umbraco-9/');   
        cy.get(".post-title").invoke("text").should("eq", "Site Variables in Umbraco 9");
    });

    it('Then verify expected post tags', () => {
        cy.visit('https://adolfi.dev/blog/site-variables-in-umbraco-9/');   
        cy.get(".tags > div > a").invoke("text").should("eq", "Umbraco");
    });
})