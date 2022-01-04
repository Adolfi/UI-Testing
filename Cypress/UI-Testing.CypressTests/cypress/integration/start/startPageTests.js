describe('When visiting startpage', () => {
    it('Then verify startpage is accessible', () => {
        cy.visit('https://adolfi.dev/');        
    });

    it('Then verify that visitor can click on first post', () => {
        cy.visit('https://adolfi.dev/');
        cy.get('.post-title:first').click();
        cy.url().should('eq', 'https://adolfi.dev/blog/umbraco-project-structure/');
    });
    
    it('Then verify that visitor can click on first tag', () => {
        cy.visit('https://adolfi.dev/');
        cy.get('.blog-description a:first').click();
        cy.url().should('eq', 'https://adolfi.dev/tags/umbraco');
    });
})